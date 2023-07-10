using Adapter;

PolarGraph polarGraph = new PolarGraph();
IGraph graph = new PolarGraphAdapter(polarGraph);
graph.Point(3, 4);