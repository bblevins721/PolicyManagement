#ifndef POLICY_H
#define POLICY_H

#include <stddef.h>

typedef struct Policy {
    int id;
    char title[256];
    char content[1024];
    int version;
} Policy;

Policy *create_policy(int id, const char *title, const char *content, int version);
void update_policy(Policy *policy, const char *title, const char *content, int version);
void delete_policy(Policy *policy);
void print_policy(const Policy *policy);

#endif /* POLICY_H */
