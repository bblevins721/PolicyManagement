class Policy:
    """Represents a policy with version history."""

    def __init__(self, policy_id: str, title: str, content: str):
        self.policy_id = policy_id
        self.title = title
        self.content = content
        self.versions = [content]

    def update(self, new_content: str) -> None:
        """Update policy content and track version history."""
        self.content = new_content
        self.versions.append(new_content)


class PolicyStore:
    """In-memory store for policies."""

    def __init__(self) -> None:
        self.policies: dict[str, Policy] = {}

    def add_policy(self, policy_id: str, title: str, content: str) -> None:
        if policy_id in self.policies:
            raise ValueError(f"Policy {policy_id} already exists")
        self.policies[policy_id] = Policy(policy_id, title, content)

    def edit_policy(self, policy_id: str, new_content: str) -> None:
        if policy_id not in self.policies:
            raise KeyError(f"Policy {policy_id} not found")
        self.policies[policy_id].update(new_content)

    def delete_policy(self, policy_id: str) -> None:
        if policy_id not in self.policies:
            raise KeyError(f"Policy {policy_id} not found")
        del self.policies[policy_id]

    def view_policy(self, policy_id: str) -> Policy:
        if policy_id not in self.policies:
            raise KeyError(f"Policy {policy_id} not found")
        return self.policies[policy_id]

    def list_policies(self) -> list[Policy]:
        return list(self.policies.values())
