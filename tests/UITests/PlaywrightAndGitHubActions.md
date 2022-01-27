---
marp: true
paginate: true
header: Playwright Zero to Hero
---

# **Playwright** - Zero* to Hero
**With GitHub Actions**

### Chris Usher
**SDET** @ INSTANDA
 
@testingpro
[GitHub - chrisusher](https://github.com/chrisusher)

---

# About Me

## **Test Analyst** -> **SDET** -> **Test Lead** -> **QA Manager** -> **Head of QA** -> **SDET**

### ~8 years as a Selenium User

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

## Continuous Integration (CI)

### Why should Tests run in CI?

# **It's *NOT* automated if there are Humans involved during the process!!*** 

###### We can start a pipeline which causes tests to run, of course!

---

## GitHub Actions Time

### *Demo* - [Create Action which runs Smoke Tests on Demand](https://github.com/chrisusher/mslearn-microservices-devops-aspnet-core/actions/new) 

---

## (Extra Credit, if Time) Run Tests after K8s Deployment

---

# Conclusion?...

---

# Playwright for the Win!