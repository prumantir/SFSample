using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Label = Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label;
namespace SFSample
{
    public partial class DiagramController : Controller
    {
        //
        // GET: /Diagram/
        public ActionResult DiagramFeatures()
        {
            DiagramProperties model = new DiagramProperties();
            model.Height = "600px";
            model.Width = "900px";
            BasicShape newIdea = CreateNode("NewIdea", 150, 60, 300, 60, "New Idea Identified");
            newIdea.Shape = BasicShapes.Path;
            newIdea.PathData = "M 45 220 L 45 220 A 20 30 0 0 1 45 280 L 45 280 A 20 30 0 0 1 45 220 Z";
            BasicShape meeting = CreateNode("Meeting", 150, 60, 300, 150, "Meeting with board");
            BasicShape boardDecision = CreateNode("BoardDecision", 150, 100, 300, 270, "Board decides \\nwhether to proceed");
            LabelMargin margin = new LabelMargin(0, 20, 20, 0);
            ((Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label)boardDecision.Labels[0]).Margin = margin;
            boardDecision.Shape = BasicShapes.Polygon;
            boardDecision.Points = GetDecisionPoints();
            BasicShape project = CreateNode("project", 150, 100, 300, 420, "Find Project manager");
            project.Shape = BasicShapes.Polygon;
            project.Points = GetDecisionPoints();
            BasicShape end = CreateNode("End", 120, 60, 300, 545, "Implement\\n and Deliver");
            BasicShape decision = CreateNode("Decision", 250, 60, 550, 60, "Decision Process for new software ideas");
            Collection points = new Collection();
            points.Add(new DiagramPoint(280, 60));
            points.Add(new DiagramPoint(400, 60));
            points.Add(new DiagramPoint(400, 110));
            points.Add(new DiagramPoint(260, 110));
            points.Add(new DiagramPoint(260, 75));
            decision.Shape = BasicShapes.Polygon;
            decision.Points = points;
            decision.FillColor = "#858585";
            decision.BorderColor = "#1BA0E2";
            BasicShape reject = CreateNode("Reject", 150, 60, 550, 270, "Reject and write report");
            BasicShape resources = CreateNode("Resources", 150, 60, 550, 420, "Hire new resources");
            ConnectNode(model, newIdea, meeting, "", false);
            ConnectNode(model, meeting, boardDecision, "", false);
            ConnectNode(model, boardDecision, reject, "No", true);
            ConnectNode(model, boardDecision, project, "Yes", true);
            ConnectNode(model, project, resources, "No", true);
            ConnectNode(model, project, end, "No", true);
            model.Nodes.Add(newIdea);
            model.Nodes.Add(meeting);
            model.Nodes.Add(boardDecision);
            model.Nodes.Add(project);
            model.Nodes.Add(end);
            model.Nodes.Add(decision);
            model.Nodes.Add(reject);
            model.Nodes.Add(resources);
            model.EnableContextMenu = false;
            model.SnapSettings.SnapConstraints = SnapConstraints.ShowLines | SnapConstraints.SnapToLines;
            ViewData["diagramModel"] = model;
            return View();
        }
        private BasicShape CreateNode(String name, double width, double height, double offsetx, double offsety, string labelText)
        {
            BasicShape node = new BasicShape();
            node.Name = name;
            node.Width = width;
            node.Height = height;
            node.OffsetX = offsetx;
            node.OffsetY = offsety;
            node.FillColor = "#1BA0E2";
            node.BorderColor = "#1BA0E2";
            Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label label = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label();
            label.Text = labelText;
            label.FontColor = "white";
            label.Name = name + "_label";
            node.Labels.Add(label);
            return node;
        }
        private Collection GetDecisionPoints()
        {
            Collection points = new Collection();
            points.Add(new DiagramPoint(310, 50));
            points.Add(new DiagramPoint(340, 80));
            points.Add(new DiagramPoint(310, 110));
            points.Add(new DiagramPoint(280, 80));
            return points;
        }
        private void ConnectNode(DiagramProperties model, BasicShape targetNode, BasicShape sourceNode, string labelText, bool hasLabel)
        {
            Connector connector = new Connector();
            connector.Name = "line" + model.Connectors.Count + 1;
            connector.Segments = new Collection() { new Segment(Segments.Straight) };
            connector.TargetNode = targetNode.Name;
            connector.SourceNode = sourceNode.Name;
            if (hasLabel)
            {
                Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label label = new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label();
                label.FontColor = "black";
                label.FillColor = "white";
                label.Text = labelText;
                connector.Labels.Add(label);
            }
            connector.SourceDecorator.Shape = DecoratorShapes.Arrow;
            connector.TargetDecorator.Shape = DecoratorShapes.None;
            model.Connectors.Add(connector);
        }
    }
}
