import os
import json
import subprocess
from pathlib import Path

DATA_FILE = Path(__file__).resolve().parents[1] / 'policy_management' / 'data.json'
CLI = ['python', '-m', 'policy_management.cli']


def setup_module(module):
    if DATA_FILE.exists():
        DATA_FILE.unlink()
    DATA_FILE.write_text(json.dumps({"libraries": [], "policies": []}))


def run_cmd(args):
    result = subprocess.run(CLI + args, capture_output=True, text=True)
    return result.stdout.strip()


def test_add_library_and_policy():
    out = run_cmd(['add-library', 'HR'])
    assert 'Added library' in out
    out = run_cmd(['add-policy', 'Vacation', '1', 'Take time off'])
    assert 'Added policy' in out
    data = json.loads(DATA_FILE.read_text())
    assert data['policies'][0]['title'] == 'Vacation'
    assert data['libraries'][0]['name'] == 'HR'


def test_edit_and_delete_policy():
    run_cmd(['add-library', 'IT'])
    run_cmd(['add-policy', 'Security', '2', 'Use antivirus'])
    out = run_cmd(['edit-policy', '2', '--content', 'Use strong passwords'])
    assert 'Updated policy' in out
    data = json.loads(DATA_FILE.read_text())
    policy = next(p for p in data['policies'] if p['id'] == 2)
    assert policy['content'] == 'Use strong passwords'
    out = run_cmd(['delete-policy', '2'])
    assert 'Deleted policy' in out
    data = json.loads(DATA_FILE.read_text())
    assert not any(p['id'] == 2 for p in data['policies'])
