#include "policy_library.h"
#include <stdlib.h>
#include <string.h>
#include <stdio.h>

PolicyLibrary *create_policy_library(size_t capacity) {
    PolicyLibrary *lib = (PolicyLibrary *)malloc(sizeof(PolicyLibrary));
    if (!lib) {
        return NULL;
    }
    lib->policies = (Policy *)calloc(capacity, sizeof(Policy));
    if (!lib->policies) {
        free(lib);
        return NULL;
    }
    lib->count = 0;
    lib->capacity = capacity;
    return lib;
}

void destroy_policy_library(PolicyLibrary *lib) {
    if (!lib) {
        return;
    }
    free(lib->policies);
    free(lib);
}

int add_policy(PolicyLibrary *lib, const Policy *policy) {
    if (!lib || !policy || lib->count >= lib->capacity) {
        return -1;
    }
    lib->policies[lib->count] = *policy;
    lib->count++;
    return 0;
}

static int find_policy_index(const PolicyLibrary *lib, int id) {
    for (size_t i = 0; i < lib->count; ++i) {
        if (lib->policies[i].id == id) {
            return (int)i;
        }
    }
    return -1;
}

int remove_policy(PolicyLibrary *lib, int id) {
    if (!lib) {
        return -1;
    }
    int idx = find_policy_index(lib, id);
    if (idx < 0) {
        return -1;
    }
    for (size_t i = idx; i + 1 < lib->count; ++i) {
        lib->policies[i] = lib->policies[i + 1];
    }
    lib->count--;
    return 0;
}

Policy *get_policy(const PolicyLibrary *lib, int id) {
    if (!lib) {
        return NULL;
    }
    int idx = find_policy_index(lib, id);
    if (idx < 0) {
        return NULL;
    }
    return &lib->policies[idx];
}

void print_policy_library(const PolicyLibrary *lib) {
    if (!lib) {
        return;
    }
    for (size_t i = 0; i < lib->count; ++i) {
        printf("-- Policy %zu --\n", i + 1);
        print_policy(&lib->policies[i]);
    }
}
