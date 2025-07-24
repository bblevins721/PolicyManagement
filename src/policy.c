#include "policy.h"
#include <stdlib.h>
#include <string.h>
#include <stdio.h>

Policy *create_policy(int id, const char *title, const char *content, int version) {
    Policy *p = (Policy *)malloc(sizeof(Policy));
    if (!p) {
        return NULL;
    }
    p->id = id;
    p->version = version;
    if (title) {
        strncpy(p->title, title, sizeof(p->title) - 1);
        p->title[sizeof(p->title) - 1] = '\0';
    } else {
        p->title[0] = '\0';
    }
    if (content) {
        strncpy(p->content, content, sizeof(p->content) - 1);
        p->content[sizeof(p->content) - 1] = '\0';
    } else {
        p->content[0] = '\0';
    }
    return p;
}

void update_policy(Policy *p, const char *title, const char *content, int version) {
    if (!p) {
        return;
    }
    if (title) {
        strncpy(p->title, title, sizeof(p->title) - 1);
        p->title[sizeof(p->title) - 1] = '\0';
    }
    if (content) {
        strncpy(p->content, content, sizeof(p->content) - 1);
        p->content[sizeof(p->content) - 1] = '\0';
    }
    p->version = version;
}

void delete_policy(Policy *p) {
    free(p);
}

void print_policy(const Policy *p) {
    if (!p) {
        return;
    }
    printf("Policy ID: %d\n", p->id);
    printf("Title: %s\n", p->title);
    printf("Content: %s\n", p->content);
    printf("Version: %d\n", p->version);
}
