Feature: Users can Login and Invalid Users cannot login

   Scenario Outline: Successful Login Attempts
      Given I am not logged in
      When I login with Email '<Email>' and Password '<Password>'
      Then The login attempt is successful

      Examples:
         | Email              | Password | SuccessExpected |
         | demo@microsoft.com | Password | true            |

   Scenario Outline: Invalid Login Attempts
      Given I am not logged in
      When I login with Email '<Email>' and Password '<Password>'
      Then The login attempt is not successful

      Examples:
         | Email               | Password  | SuccessExpected |
         | demo1@microsoft.com | Password1 | false            |