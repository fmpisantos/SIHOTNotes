### General

This service can be used to query features attached to a specific product and whether they are enabled or not

### Input

- Product: SIHOT product to query features for. Valid options can be queried through the combobox with key "SihotProduct"

### Output

- type: Indicated the type of feature. (1 = by instalation, 2 = by hotel, 3 = by user group)

- id:
    | Feature type  | Description   |
    |---------------|---------------|
    | serial        | id            |
    | registry      | class         |
    | feature right | feature right |

- name:
    | Feature type  | Description   |
    |---------------|---------------|
    | serial        | name          |
    | registry      | value         |
    | feature right | user group    |

- isEnabled
