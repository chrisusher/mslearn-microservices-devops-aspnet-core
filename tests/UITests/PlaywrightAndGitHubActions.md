---
marp: true
paginate: true
header: Playwright Zero to Hero
---

# **Playwright** - Zero* to Hero
**With GitHub Actions**

### Chris Usher ###
@testingpro
[GitHub - chrisusher](https://github.com/chrisusher)

---

## Tonight's Tools:

    * dotnet core (C#)
    * Specflow (BDD)
    * GitHub Actions
    * Powershell
    * Azure Kubernetes Service (AKS)

- [Tonight's Website Under Test](http://137.135.47.40)

---

## Install Playwright

[Playwright's Docs](https://playwright.dev/)

`dotnet tool install --global Microsoft.Playwright.CLI`
`playwright install`

### *Demo* - Playwright Recorder

`playwright codegen`

--- 

## Playwright Structure

- **Playwright Instance**

    - Browser Context

        - Page

### Implement `BrowserHelper.cs`

--- 

## Tonight's Test

---

## Page Object Models?

**Not intuitive but possible, with a NuGet Package**

### *Demo* - Write a Page Object Model from Scratch 

---

## UI Controllers?

---

## Implement Step Definitions

---

## Run the Test Locally first!  :open_mouth:

---

## Tracing - A Game-Changer!  :fire:

---

## GitHub Actions Time

# [Actions](https://github.com/chrisusher/mslearn-microservices-devops-aspnet-core/actions/new)

### *Demo* - Create Action which runs Smoke Tests on Demand

---

## (Extra Credit, if Time) Run Tests after K8s Deployment