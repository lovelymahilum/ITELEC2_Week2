class Tenant
{
    public string TenantName { get; }
    public string RoomNumber { get; }
    public decimal MonthlyRent { get; }
    public decimal Balance { get; private set; }
    public bool IsMovedOut { get; private set; }

    public Tenant(string tenantName, string roomNumber, decimal monthlyRent)
    {
        if (monthlyRent <= 0)
            throw new ArgumentException("Monthly rent must be greater than zero.");

        TenantName = tenantName;
        RoomNumber = roomNumber;
        MonthlyRent = monthlyRent;
        Balance = 0m;
        IsMovedOut = false;
    }

    // Adds one month of rent to what the tenant owes.
    // A tenant who has already moved out cannot be charged.
    public bool ChargeRent()
    {
        if (IsMovedOut) return false;
        Balance += MonthlyRent;
        return true;
    }

    // Records a payment. It must be positive and cannot be more than the balance owed.
    public bool PayRent(decimal amount)
    {
        if (amount <= 0 || amount > Balance) return false;
        Balance -= amount;
        return true;
    }

    // RULE: a tenant with an unpaid balance cannot be marked as moved out.
    public bool MoveOut()
    {
        if (IsMovedOut || Balance > 0) return false;
        IsMovedOut = true;
        return true;
    }
}