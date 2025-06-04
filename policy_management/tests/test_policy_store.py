from policy_management.policy_store import PolicyStore


def test_add_edit_delete_policy():
    store = PolicyStore()
    store.add_policy("1", "First", "content v1")

    policy = store.view_policy("1")
    assert policy.title == "First"
    assert policy.content == "content v1"

    store.edit_policy("1", "content v2")
    policy = store.view_policy("1")
    assert policy.content == "content v2"
    assert policy.versions == ["content v1", "content v2"]

    store.delete_policy("1")
    assert store.list_policies() == []
