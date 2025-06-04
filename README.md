# README #

This repository hosts an open source Policy Management platform for small to medium businesses.

### What is this repository for? ###

The aim is to provide a lightweight system for managing company policies.

### Incremental Development Plan ###

Phase 1:
 - Ability to add, edit, view and delete policies.
 - Ability to create policy libraries.
 - Ability to create multiple policy versions.
 - MI information on policies

Phase 2:
 - Implement Authentication: forms authentication
 - Implement Authorization and limitedrole base access (publisher (person who can create policy) & end user (person who reads and complies ot policy)).

Phase 3/4 (TBC):
 - Implement Policy Sunsetting and Review: Ability to schdeule a release of a policy version.

Phase 3/4 (TBC):
 - Implement test framework.

Phase 5:
 - Workflow: Add authentication and workflow management layer to create, update, and properly route policies.

As each of the above phases are constructed, a tick (`) will be added.

Known Issues/Bugs:

### Development ###

A minimal Python implementation for Phase 1 exists in `policy_management/`.
Install dependencies and run tests with:

```bash
pip install -r requirements.txt
pytest
```
