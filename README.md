# ITELEC2_Week2

**Student:** Lovely L. Mahilum
**Entity:** Tenant (boarding house rent tracking)

## What it does
The `Tenant` class stores a tenant's name, room, monthly rent, balance, and move-out status. It has three methods: `ChargeRent()`, `PayRent(amount)`, and `MoveOut()`.

## Rule it protects
A tenant who still owes rent cannot be marked as moved out. `Balance` and `IsMovedOut` have private setters, so they can change only through the class's methods.

## How to run
dotnet run --project Week2_Prototype

## Files
- `Week2_Prototype/Tenant.cs`: the class
- `Week2_Prototype/Program.cs`: console tests with two objects and rejected actions
