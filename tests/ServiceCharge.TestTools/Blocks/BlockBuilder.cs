﻿using ServiceCharge.Entities;

namespace ServiceCharge.TestTools.Blocks;

public class BlockBuilder
{
    private readonly Block _block = new()
    {
        Name = "Dummy_Block_Name",
        CreationDate = DateTime.UtcNow,
        FloorCount = 0
    };

    public BlockBuilder WithFloorCount(int value)
    {
        _block.FloorCount = value;
        return this;
    }

    public Block Build()
    {
        return _block;
    }
}