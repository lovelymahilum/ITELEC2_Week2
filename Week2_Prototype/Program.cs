var first = new Tenant("Maria Santos", "Room 1", 3000m);
var second = new Tenant("Juan Dela Cruz", "Room 2", 2500m);

// Valid action: charge this month's rent
Console.WriteLine($"Charge rent to Maria: {first.ChargeRent()}");
Console.WriteLine($"Maria's balance: {first.Balance}");

// Rule violation: cannot move out while owing rent
Console.WriteLine($"Maria moves out while owing: {first.MoveOut()}");

// Pay in full, then moving out is allowed
Console.WriteLine($"Maria pays 3000: {first.PayRent(3000m)}");
Console.WriteLine($"Maria moves out after paying: {first.MoveOut()}");
Console.WriteLine($"Maria IsMovedOut: {first.IsMovedOut}");

// Moved-out tenant cannot be charged again
Console.WriteLine($"Charge rent to moved-out Maria: {first.ChargeRent()}");

// Second object works independently
Console.WriteLine($"Charge rent to Juan: {second.ChargeRent()}");
Console.WriteLine($"Juan pays 1000: {second.PayRent(1000m)}");
Console.WriteLine($"Juan's balance: {second.Balance}");
Console.WriteLine($"Juan moves out while owing: {second.MoveOut()}");