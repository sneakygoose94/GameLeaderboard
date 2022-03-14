using System;
using GameLeaderboardApp;
using Xunit;

namespace GameLeaderboard.Tests;

public class PlayerTest
{
    [Fact]
    public async void Test1()
    {
        // arrange
       
        var playr = new Player("Ducksu");

        playr.AddScore(459);
        playr.AddScore(389);
        playr.AddScore(711);



        // act

        var result = playr.GetScoring();

        //assert

        Assert.Equal(519, result.Average);
        Assert.Equal(711, result.High);
        Assert.Equal(389, result.Low);


    }
}