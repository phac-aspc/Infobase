// @flow
import * as React from 'react';
import * as ReactDOM from 'react-dom';
import { initChart, updateChart } from '../renderChart';
import type { ChartData } from '../types';

export class Chart extends React.Component<{chartData: ChartData}, {isMounted: boolean}> {
    graph: ?Element;

    componentDidMount() {
        if (this.graph)
        initChart(this.graph, this.props.chartData)
        this.setState({isMounted: true})
    }
    componentDidUpdate() {
        if (this.state.isMounted && this.graph)
            updateChart(this.graph, this.props.chartData)
    }
    render() {
        return (
            <div>
                <svg className="chart" ref={self => this.graph = self} id="graph" zoomAndPan="magnify" viewBox="0 0 620 420" preserveAspectRatio="xMidYMid meet" style={{width: 100 + "%"}}>
                    <foreignObject>
                        <h6 id="chartTitle" style={{
                    marginLeft: 60,
                    marginTop: 0,
                    width: 500,
                    textAlign: "center"
                }}></h6>
                    </foreignObject>
                    <g className="y-axis"></g>
                    <g className="x-axis"></g>
                </svg>
            </div>
        )
        
        //<p>{JSON.stringify(this.props.chartData, null, 4)}</p>
    }
}