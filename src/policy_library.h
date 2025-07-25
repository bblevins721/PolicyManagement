#ifndef POLICY_LIBRARY_H
#define POLICY_LIBRARY_H

#include "policy.h"
#include <stddef.h>

typedef struct PolicyLibrary {
    Policy *policies;
    size_t count;
    size_t capacity;
} PolicyLibrary;

PolicyLibrary *create_policy_library(size_t capacity);
void destroy_policy_library(PolicyLibrary *library);
int add_policy(PolicyLibrary *library, const Policy *policy);
int remove_policy(PolicyLibrary *library, int id);
Policy *get_policy(const PolicyLibrary *library, int id);
void print_policy_library(const PolicyLibrary *library);

#endif /* POLICY_LIBRARY_H */
