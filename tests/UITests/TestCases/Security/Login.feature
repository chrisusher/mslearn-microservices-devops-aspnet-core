Feature: Users can Login and Invalid Users cannot login

   @Smoke
   Scenario Outline: Valid Users can Successfully Login
      Given I am not logged in
      When I login with Email '<Email>' and Password '<Password>'
      Then The login attempt is successful

      Examples:
         | Email                  | Password   |
         | demouser@microsoft.com | Pass@word1 |

   @wip
   Scenario Outline: Invalid Are Unable to Login
      Given I am not logged in
      When I login with Email '<Email>' and Password '<Password>'
      Then The login attempt is not successful

      Examples:
         | Email               | Password  |
         | demo1@microsoft.com | Password1 |