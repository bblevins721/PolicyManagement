import argparse
from itertools import count
from .storage import load_data, save_data


def get_next_id(items):
    existing_ids = {item['id'] for item in items}
    for i in count(1):
        if i not in existing_ids:
            return i

def add_library(name):
    data = load_data()
    libraries = data['libraries']
    if any(lib['name'] == name for lib in libraries):
        print(f"Library '{name}' already exists")
        return
    lib_id = get_next_id(libraries)
    libraries.append({'id': lib_id, 'name': name})
    save_data(data)
    print(f"Added library {name} (id: {lib_id})")


def list_libraries():
    data = load_data()
    for lib in data['libraries']:
        print(f"{lib['id']}: {lib['name']}")


def add_policy(title, library_id, content):
    data = load_data()
    policies = data['policies']
    policy_id = get_next_id(policies)
    policies.append({
        'id': policy_id,
        'title': title,
        'library_id': library_id,
        'content': content,
        'version': 1
    })
    save_data(data)
    print(f"Added policy {title} (id: {policy_id})")


def list_policies():
    data = load_data()
    for p in data['policies']:
        print(f"{p['id']}: {p['title']} v{p['version']} (library {p['library_id']})")


def view_policy(pid):
    data = load_data()
    for p in data['policies']:
        if p['id'] == pid:
            print(p['title'])
            print(f"Version: {p['version']}")
            print(p['content'])
            return
    print(f"Policy {pid} not found")


def delete_policy(pid):
    data = load_data()
    policies = data['policies']
    for i, p in enumerate(policies):
        if p['id'] == pid:
            del policies[i]
            save_data(data)
            print(f"Deleted policy {pid}")
            return
    print(f"Policy {pid} not found")


def edit_policy(pid, title=None, content=None, library_id=None):
    data = load_data()
    for p in data['policies']:
        if p['id'] == pid:
            if title:
                p['title'] = title
            if content:
                p['content'] = content
            if library_id is not None:
                p['library_id'] = library_id
            p['version'] += 1
            save_data(data)
            print(f"Updated policy {pid}")
            return
    print(f"Policy {pid} not found")


def build_parser():
    parser = argparse.ArgumentParser(description="Policy Management CLI")
    sub = parser.add_subparsers(dest='cmd')

    add_lib = sub.add_parser('add-library')
    add_lib.add_argument('name')

    list_lib = sub.add_parser('list-libraries')

    add_p = sub.add_parser('add-policy')
    add_p.add_argument('title')
    add_p.add_argument('library_id', type=int)
    add_p.add_argument('content')

    list_p = sub.add_parser('list-policies')

    view_p = sub.add_parser('view-policy')
    view_p.add_argument('policy_id', type=int)

    del_p = sub.add_parser('delete-policy')
    del_p.add_argument('policy_id', type=int)

    edit_p = sub.add_parser('edit-policy')
    edit_p.add_argument('policy_id', type=int)
    edit_p.add_argument('--title')
    edit_p.add_argument('--content')
    edit_p.add_argument('--library_id', type=int)

    return parser


def main(argv=None):
    parser = build_parser()
    args = parser.parse_args(argv)
    if args.cmd == 'add-library':
        add_library(args.name)
    elif args.cmd == 'list-libraries':
        list_libraries()
    elif args.cmd == 'add-policy':
        add_policy(args.title, args.library_id, args.content)
    elif args.cmd == 'list-policies':
        list_policies()
    elif args.cmd == 'view-policy':
        view_policy(args.policy_id)
    elif args.cmd == 'delete-policy':
        delete_policy(args.policy_id)
    elif args.cmd == 'edit-policy':
        edit_policy(args.policy_id, args.title, args.content, args.library_id)
    else:
        parser.print_help()


if __name__ == '__main__':
    main()
