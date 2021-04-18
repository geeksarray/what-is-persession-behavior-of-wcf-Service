# What is PerSession Behavior of WCF Service

This article explains what is PerSession Behavior in WCF Services, how to configure and implement PerSession behavior and understand the difference between PerCall and PerSession WCF services

## What happens when the WCF service configured as Per Session?
When client creates a new proxy of WCF service configured as InstanceContextMode=InstanceContextMode.PerSession, the WCF service creates a dedicated instance for a particular client proxy and handles all subsequent calls through this instance until the client closes the proxy.

Each private session uniquely binds a proxy to the particular instance. Note that the client session has one service instance per proxy. If the client creates another proxy to the same or a different service endpoint, then the new proxy will have a different dedicated instance.

As each instance maintains a session in service memory, this behavior creates scalability and transaction issues like the classic client-server model. With normal infrastructure, it is difficult to handle more than a dozen ongoing calls due to the cost associated with each dedicated instance.

WCF supports three kinds of behavior - PerCall, PerSession, and Single. When you use bindings like wsHttpBinding that supports reliable sessions, PerSession is the default behavior.

See [implementation of WCF PerSession behavior in WCF Services](https://geeksarray.com/blog/what-is-persession-behavior-of-wcf-Service)

## WCF services and Client app code
1. [WCF Services library](https://github.com/geeksarray/what-is-persession-behavior-of-wcf-Service/tree/main/PerSessionWCFService): WCF service with PerSession configuration 

1. [Client App](https://github.com/geeksarray/what-is-persession-behavior-of-wcf-Service/tree/main/ClientApp): Console app consume WCF Services


![implementation of WCF PerSession behavior in WCF Services](https://geeksarray.com/images/blog/PerSession.png)
