# Netified.LicenseManager.Api.Abstractions

![GitHub](https://img.shields.io/github/license/netified/license-manager-api-abstractions?style=for-the-badge)
![GitHub Sponsors](https://img.shields.io/github/sponsors/netified?style=for-the-badge)
![GitHub Workflow Status](https://img.shields.io/github/workflow/status/netified/license-manager-api-abstractions/Continuous%20integration?style=for-the-badge)
![Nuget](https://img.shields.io/nuget/dt/Netified.LicenseManager.Api.Abstractions?style=for-the-badge)
![Nuget](https://img.shields.io/nuget/v/Netified.LicenseManager.Api.Abstractions?style=for-the-badge)

This package contains a complete set of type and API abstractions for the Licence Manager API.
It provides no concrete implementations; rather, it acts as a general, library-agnostic standard definition of Licence Manager's API.

These types serve as the foundation of Licence Manager's entire API surface, but can just as easily be used to implement your own Licence Manager library, independently of [Netified.LicenseManager.Api](https://github.com/netified/license-manager-api).

The primary goal of this project is to model Licence Manage's API as closely as possible, while at the same time applying appropriate C# practices

## Structure

The library is divided into type categories, organized to match Licence Manager's API documentation as closely as is realistic. Each object defined by Licence Manager has a corresponding interface, with inline documentation that matches Licence Manager's.

The REST API surface is similarly divided by purpose, wherein related endpoints are grouped together (application, audit log, channel, guild, etc).

## Usage

No particular usage recommendations exist for this library. It's up to you to decide how to implement or utilize these definitions.
