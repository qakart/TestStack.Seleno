﻿using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using TestStack.Seleno.PageObjects.Actions;

namespace TestStack.Seleno.PageObjects.Assertions
{
    public interface IElementAssert
    {
        IElementFinder Find { get; }
        IElementAssert DoNotExist(By findExpression, string message = null, TimeSpan maxWait = default(TimeSpan));
        IElementAssert DoNotExist(Locators.By.jQueryBy findExpression, string message = null, TimeSpan maxWait = default(TimeSpan));
        IElementAssert Exist(By findExpression, string message = null, TimeSpan maxWait = default(TimeSpan));
        IElementAssert Exist(Locators.By.jQueryBy findExpression, string message = null, TimeSpan maxWait = default(TimeSpan));
        IElementAssert ConformTo(By findExpression, Action<IEnumerable<IWebElement>> assertion, TimeSpan maxWait = default(TimeSpan));
        IElementAssert ConformTo(Locators.By.jQueryBy findExpression, Action<IEnumerable<IWebElement>> assertion, TimeSpan maxWait = default(TimeSpan));
    }
}