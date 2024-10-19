using System;
using System.Collections.Generic;

interface IBroadbandPlan
{
    int GetBroadbandPlanAmount();
}


class Black : IBroadbandPlan
{
    private bool _isSubscriptionValid;
    private int _discountPercentage;
    private const int PlanAmount = 3000;

    public Black(bool isSubscriptionValid, int discountPercentage)
    {
        _isSubscriptionValid = isSubscriptionValid;

        if (discountPercentage > 50)
            _discountPercentage = 50;
        else
            _discountPercentage = discountPercentage;
    }

    public int GetBroadbandPlanAmount()
    {
        if (_isSubscriptionValid)
        {
            int discountAmount = (PlanAmount * _discountPercentage) / 100;
            return PlanAmount - discountAmount;
        }
        else
        {
            return PlanAmount;
        }
    }
}


class Gold : IBroadbandPlan
{
    private bool _isSubscriptionValid;
    private int _discountPercentage;
    private const int PlanAmount = 2000;

    public Gold(bool isSubscriptionValid, int discountPercentage)
    {
        _isSubscriptionValid = isSubscriptionValid;

        if (discountPercentage > 30)
            _discountPercentage = 30;
        else
            _discountPercentage = discountPercentage;
    }

    public int GetBroadbandPlanAmount()
    {
        if (_isSubscriptionValid)
        {
            int discountAmount = (PlanAmount * _discountPercentage) / 100;
            return PlanAmount - discountAmount;
        }
        else
        {
            return PlanAmount;
        }
    }
}


class SubscribePlan
{
    private IList<IBroadbandPlan> _broadbandPlans;

    public SubscribePlan(IList<IBroadbandPlan> broadbandPlans)
    {
        _broadbandPlans = broadbandPlans;
    }

    public void DisplaySubscriptionPlan()
    {
        foreach (var plan in _broadbandPlans)
        {
            Console.WriteLine($"Plan: {plan.GetType().Name}, Amount: {plan.GetBroadbandPlanAmount()}");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        var plans = new List<IBroadbandPlan>
        {
            new Black(true, 20),
            new Gold(false, 15)
        };

        var subscribePlan = new SubscribePlan(plans);
        subscribePlan.DisplaySubscriptionPlan();
    }
}