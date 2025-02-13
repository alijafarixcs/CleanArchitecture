# Authentication API

## Table of Contents (up to date)
- [Buber Dinner API](#buber-dinner-api)
- [Auth](#auth)
  - [Register](#register)
    - [Register Request](#register-request)
    - [Register Response](#register-response)
  - [Login](#login)
    - [Login Request](#login-request)
    - [Login Response](#login-response)

## Auth

### Register

```js
POST ({host}/auth/register)
```

#### Register Request

```json
{
  "firstName": "Ali",
  "lastName": "Jafari",
  "email": "alijafarixcs@gmail.com",
  "password": "Aydin123123!"
}
```
#### Register Response (200 OK)

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "firstName": "Ali",
  "lastName": "Jafari",
  "email": "alijafarixcs@gmail.com",
  "token": "eyJhbGciOi9.Y3z2CMaApD4G3Hxf0qCM2CmP9oLbG3HyxblhxKtUV5M"
}
```
