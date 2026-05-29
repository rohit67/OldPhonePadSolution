# Old Phone Pad Decoder

## Overview

This project is a production-style implementation of an old mobile phone keypad decoder built in C# using .NET 8.

The solution is structured into separate projects to simulate a real-world engineering environment:

* `OldPhonePadLibrary` → reusable decoding logic
* `OldPhonePadApi` → REST API wrapper demo for customer integration
* `OldPhonePadTests` → automated unit tests

---

## Features

* Supports multi-tap keypad decoding
* Handles pause spacing between characters
* Supports backspace (`*`)
* Supports send/end character (`#`)
* Includes automated tests
* Includes Swagger API demo

---

## Example Inputs

| Input                | Output   |
| -------------------- | -------- |
| `33#`                | `E`      |
| `227*#`              | `B`      |
| `4433555 555666#`    | `HELLO`  |
| `222 2 22#`          | `CAB`    |
| `8 88777444666*664#` | `TURING` |

---

## Running the API

From terminal:

```bash
dotnet run --project OldPhonePadApi
```

Open Swagger:

```text
http://localhost:5065/swagger
```

---

## API Example

### Request

```json
{
  "input": "4433555 555666#"
}
```

### Response

```json
{
  "output": "HELLO"
}
```

---

## Running Tests

```bash
dotnet test
```

---

## Architecture Notes

The keypad decoding logic was intentionally separated into a reusable class library to support maintainability and future integrations beyond REST APIs.

The API project demonstrates how external customers could consume the library in real-world applications.

---

## AI Usage Disclosure

AI assistance was used for:

* code cleanup
* architectural guidance
* documentation refinement

Core implementation logic and project assembly were completed manually as part of the engineering exercise.
Built using C# and .NET 8