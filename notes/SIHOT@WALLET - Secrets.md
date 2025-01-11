# AWS secrets manager .NET caching
- https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieving-secrets_cache-net.html

# What needs to be saved as secret
| Type | SECRET | PUBLIC |
|------|--------|--------|
|Google|private_key_id|project_id|
| |private_key|client_email|
| | |auth_uri|
| | |token_uri|
|Apple|signerKey.pem|wwdr.pem|
| |signerCert.pem (*)| |

Note:
- (*) 
    - The signedCert contains the public certificate associated with your Apple Developer account. While it is not as sensitive as the private key, it still links your account to the signing process.
    - Storage: This certificate can be stored in a less restricted environment (e.g., a configuration file or your application environment), but should still be treated with care.
    - Access: Limit access to this file to your application or processes involved in pass signing.
