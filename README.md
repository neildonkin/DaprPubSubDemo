# DaprPubSubDemo
Sample code show how to use dapr pub/sub capabilities.

Once you start the application using `dapr run` you must use an http post as follows:

`http://localhost:3500/v1.0/publish/pubsub/ordertopic`

`application/json`

`{
   "id" : "12345",
   "reference" : "pie",
   "product" : "Mince Pie",
   "quantity" : 1,
   "price" : 1.70
}`
