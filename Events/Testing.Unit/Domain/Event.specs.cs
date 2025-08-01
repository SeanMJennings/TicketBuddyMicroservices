﻿using NUnit.Framework;

namespace Unit.Domain;

public partial class EventSpecs
{
    [Test]
    public void an_event_must_have_a_name()
    {
        Scenario(() =>
        {
            Given(valid_inputs);
            And(a_null_user_name);
            When(Validating(creating_an_event));
            Then(Informs("Name cannot be empty"));
        });        
        
        Scenario(() =>
        {
            Given(valid_inputs);
            And(an_event_name);
            When(Validating(creating_an_event));
            Then(Informs("Name cannot be empty"));
        });
        
        Scenario(() =>
        {
            Given(valid_inputs);
            And(an_event_with_non_alphabetical_characters);
            When(Validating(creating_an_event));
            Then(Informs("Name can only have alphabetical characters"));
        }); 
    }    
    
   
    [Test]
    public void can_create_valid_event()
    {
        Given(valid_inputs);
        When(creating_an_event);
        Then(the_event_is_created);
    }
}