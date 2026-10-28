string claimstatus = "pending";

string status = claimstatus switch
{
    "pending"=>"waiting for review",
    "Approved" =>"ready for payment",
    "reject" => "rejected transaction"
};


Console.WriteLine(status);