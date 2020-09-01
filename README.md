# Using ASP.NET MVC Model Annotations

In this repo has some examples about how to use Annotation in Models and make the user entries more consistent.

Submiting an empty form all errors generated by the model annotations will apear on the top of the form like this:

![empty form submit result](https://raw.githubusercontent.com/Evndroo/ASP.NET_MVC_Model_Annotations/master/imgs/Errors%20generated.PNG)

*Need an Razor like this in the View:*

```
    @Html.ValidationSummary()
```

___

[Click here](https://github.com/Evndroo/ASP.NET_MVC_Model_Annotations/blob/master/Projeto1604/Models/QuestionarioModel.cs) to see the example of model annotation usage.