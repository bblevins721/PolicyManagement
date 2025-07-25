# README

This repository contains an early prototype of a Policy Management platform.
It currently provides a simple command line interface to manage policies and
libraries stored in a JSON file.

## Usage

Run the CLI using Python:

```
python -m policy_management.cli [command] [options]
```

Example:

```
python -m policy_management.cli add-library "HR"
python -m policy_management.cli add-policy "Vacation" 1 "Take time off"
python -m policy_management.cli list-policies
```

## Incremental Development Plan

Phase 1:
 - Ability to add, edit, view and delete policies.
 - Ability to create policy libraries.
 - Ability to create multiple policy versions.
 - MI information on policies

Phase 2:
 - Implement Authentication: forms authentication
 - Implement Authorization and limitedrole base access (publisher (person who can create policy) & end user (person who reads and complies to policy)).

Phase 3/4 (TBC):
 - Implement Policy Sunsetting and Review: Ability to schedule a release of a policy version.
 - Implement test framework.

Phase 5:
 - Workflow: Add authentication and workflow management layer to create, update, and properly route policies.

As each of the above phases are constructed, a tick (`) will be added.

Known Issues/Bugs:

- None at this time.
