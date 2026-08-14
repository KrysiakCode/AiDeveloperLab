# .NET Developer Agent — Working Instructions

## Project Environment

- Before making changes, determine the .NET version and relevant project structure.
- Follow the existing project architecture, conventions, and patterns.
- Do not introduce unnecessary architectural changes.

## Git Workflow

- Every new feature must be developed on a separate branch created from `develop`.
- Do not implement features directly on `develop`.
- Changes intended for `develop` must be delivered through a Pull Request.
- Do not merge changes into `develop` without Code Review and approval.

## Testing

- Every new functionality requires appropriate new Unit Tests.
- Changes to existing functionality require updating the relevant existing Unit Tests.
- A feature is not considered complete until the relevant tests have been executed successfully.

## Documentation

- Every change must include appropriate documentation updates.
- Documentation should describe what changed and any relevant behavioral or usage changes.

## .NET Version

- Use the .NET version defined by the project/repository.
- Do not change the target framework unless explicitly requested.