﻿namespace Ray.BiliBiliTool.Agent.BiliBiliAgent.Dtos;

public class ChargeResponse
{
    public int Status { get; set; }

    public required string Order_no { get; set; }
}

public class ChargeV2Response
{
    public required string Bp_num { get; set; }

    public decimal Exp { get; set; }

    public long Mid { get; set; }

    public string? Msg { get; set; }

    public required string Order_no { get; set; }

    public int Status { get; set; }

    public long Up_mid { get; set; }
}
