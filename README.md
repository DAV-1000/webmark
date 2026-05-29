# Webmark

> An Azure-native AI-enhanced engineering intelligence platform built with Blazor, SQL Server, and AI-assisted engineering workflows.

---

## Overview

Webmark is a portfolio engineering platform focused on:

* engineering intelligence
* architecture traceability
* AI-assisted software delivery workflows
* repository and architecture analysis
* modular monolith architecture
* CQRS and Vertical Slice Architecture
* operational maturity on Azure

The platform is designed to demonstrate enterprise-oriented software engineering practices while remaining intentionally lightweight and deployable within Azure free-tier constraints.

---

# Core Objectives

Webmark aims to:

* understand software systems
* document engineering intent
* analyze repository structure
* visualize architecture relationships
* trace AI-generated engineering artifacts
* demonstrate governed AI-assisted workflows

---

# Technology Stack

## Frontend

* Blazor Server
* ASP.NET Core

## Backend

* .NET
* CQRS
* Vertical Slice Architecture
* Modular Monolith Architecture

## Infrastructure

* Azure App Service
* Azure SQL Database
* GitHub Actions
* Application Insights

## Data

* SQL Server
* Entity Framework Core

## AI Integration

* Azure OpenAI (planned)
* SPDD workflow orchestration
* semantic engineering retrieval (planned)

---

# Current Solution Layout

```text
Webmark.sln

/docs
    /adr
    /business-case
    /spdd
    /vision

/src
    /Webmark.Web
    /Webmark.Modules
    /Webmark.Infrastructure

/tests
    /Webmark.Tests
```

---

# Project Structure

## Webmark.Web

Primary Blazor Server host application.

Responsibilities:

* application startup
* dependency injection
* routing
* layouts and navigation
* page composition
* configuration management

---

## Webmark.Modules

Contains business capabilities organized by module and vertical slice.

Planned modules:

* Knowledge
* SPDD
* Repositories
* Architecture
* AI
* Operations

Responsibilities:

* commands
* queries
* handlers
* domain logic
* feature slices

---

## Webmark.Infrastructure

Shared infrastructure implementation.

Responsibilities:

* EF Core persistence
* SQL Server integration
* external service integrations
* AI provider abstractions
* telemetry and observability

---

## Webmark.Tests

Solution-wide automated tests.

Planned coverage:

* unit tests
* integration tests
* architecture tests

---

# Architectural Principles

The platform follows these core engineering principles:

* modular monolith first
* vertical slice organization
* pragmatic CQRS
* explainable architecture
* AI governance and traceability
* incremental delivery
* operational simplicity

---

# Planned MVP Features

## Dashboard

Platform overview including:

* repository metrics
* architecture summaries
* operational status

---

## Knowledge Workspace

Central engineering knowledge system including:

* vision statements
* business case
* ADRs
* personas
* SPDD artifacts

---

## SPDD Workflow Explorer

Traceability interface for:

* GitHub issues
* generated stories
* analyses
* prompts
* generated artifacts

---

## Repository Explorer

Repository and project analysis including:

* project discovery
* dependency analysis
* metadata extraction

---

## Architecture Visualization

Interactive architecture intelligence views including:

* dependency graphs
* bounded contexts
* coupling analysis
* modernization hotspots

---

## AI Assistant

Context-aware engineering assistant capable of answering:

* product rationale questions
* architecture questions
* workflow traceability questions
* operational guidance questions

---

# Development Status

## Week 1 Goals

* [x] Initialize solution structure
* [ ] Configure Blazor Server host
* [ ] Configure SQL Server persistence
* [ ] Establish CQRS foundations
* [ ] Configure CI/CD pipeline
* [ ] Deploy initial Azure application

---

# Repository Standards

## Documentation

Important documentation is located under `/docs`.

### ADRs

Architecture Decision Records document major engineering decisions including:

* technology choices
* architectural tradeoffs
* operational constraints

### SPDD

Structured Prompt-Driven Development artifacts and workflows.

---

# Running Locally

## Prerequisites

* .NET SDK 10+
* SQL Server LocalDB or SQL Server
* Visual Studio 2026 or Rider

---

## Initial Setup

```bash
git clone <repository-url>
cd webmark
```

Open:

```bash
Webmark.slnx
```

---

# Roadmap

## MVP

* foundational engineering knowledge platform
* SPDD workflow traceability
* AI-assisted engineering workflows
* architecture visualization
* Azure deployment

## Future Enhancements

* semantic code embeddings
* GitHub API synchronization
* multi-repository analysis
* agent workflows
* real-time collaboration
* Azure Functions extraction

---

# Engineering Philosophy

Webmark is intentionally designed to emphasize:

* engineering clarity
* maintainability
* explainability
* governance
* traceability
* operational realism

The goal is not to build speculative infrastructure, but to demonstrate practical engineering intelligence patterns using modern .NET and Azure technologies.

---

# License

Planned License:
MIT

---

# Status

Active portfolio engineering project under iterative development.
