using System.Collections.Generic;
using UnimorePocketCalculator.Pages;

namespace UnimorePocketCalculator.Data;

public class GuageChartService
{
    public Task<GuageChart[]> GetGuageAsync()
    {
        List<GuageChart> data = new List<GuageChart>();
        data.Add(new GuageChart() { Guage = "3", Inches = "0.2391", Mm = "6.073", LbFt2 = "9.754", KgM2 = "47.624" });
        data.Add(new GuageChart() { Guage = "4", Inches = "0.2242", Mm = "5.695", LbFt2 = "9.146", KgM2 = "44.656" });
        data.Add(new GuageChart() { Guage = "5", Inches = "0.2092", Mm = "5.314", LbFt2 = "8.534", KgM2 = "41.668" });
        data.Add(new GuageChart() { Guage = "6", Inches = "0.1943", Mm = "4.935", LbFt2 = "7.927", KgM2 = "38.701" });
        data.Add(new GuageChart() { Guage = "7", Inches = "0.1793", Mm = "4.554", LbFt2 = "7.315", KgM2 = "35.713" });
        data.Add(new GuageChart() { Guage = "8", Inches = "0.1644", Mm = "4.176", LbFt2 = "6.707", KgM2 = "32.745" });
        data.Add(new GuageChart() { Guage = "9", Inches = "0.1495", Mm = "3.797", LbFt2 = "6.099", KgM2 = "29.777" });
        data.Add(new GuageChart() { Guage = "10", Inches = "0.1345", Mm = "3.416", LbFt2 = "5.487", KgM2 = "26.790" });
        data.Add(new GuageChart() { Guage = "11", Inches = "0.1196", Mm = "3.038", LbFt2 = "4.879", KgM2 = "23.822" });
        data.Add(new GuageChart() { Guage = "12", Inches = "0.1046", Mm = "2.657", LbFt2 = "4.267", KgM2 = "20.834" });
        data.Add(new GuageChart() { Guage = "13", Inches = "0.0897", Mm = "2.278", LbFt2 = "3.659", KgM2 = "17.866" });
        data.Add(new GuageChart() { Guage = "14", Inches = "0.0747", Mm = "1.897", LbFt2 = "3.047", KgM2 = "14.879" });
        data.Add(new GuageChart() { Guage = "15", Inches = "0.0673", Mm = "1.709", LbFt2 = "2.746", KgM2 = "13.405" });
        data.Add(new GuageChart() { Guage = "16", Inches = "0.0598", Mm = "1.519", LbFt2 = "2.440", KgM2 = "11.911" });
        data.Add(new GuageChart() { Guage = "17", Inches = "0.0538", Mm = "1.367", LbFt2 = "2.195", KgM2 = "10.716" });
        data.Add(new GuageChart() { Guage = "18", Inches = "0.0478", Mm = "1.214", LbFt2 = "1.950", KgM2 = "9.521" });
        data.Add(new GuageChart() { Guage = "19", Inches = "0.0418", Mm = "1.062", LbFt2 = "1.705", KgM2 = "8.326" });
        data.Add(new GuageChart() { Guage = "20", Inches = "0.0359", Mm = "0.912", LbFt2 = "1.465", KgM2 = "7.151" });
        data.Add(new GuageChart() { Guage = "21", Inches = "0.0329", Mm = "0.836", LbFt2 = "1.342", KgM2 = "6.553" });
        data.Add(new GuageChart() { Guage = "22", Inches = "0.0299", Mm = "0.759", LbFt2 = "1.220", KgM2 = "5.955" });
        data.Add(new GuageChart() { Guage = "23", Inches = "0.0269", Mm = "0.683", LbFt2 = "1.097", KgM2 = "5.358" });
        data.Add(new GuageChart() { Guage = "24", Inches = "0.0239", Mm = "0.607", LbFt2 = "0.975", KgM2 = "4.760" });
        data.Add(new GuageChart() { Guage = "25", Inches = "0.0209", Mm = "0.531", LbFt2 = "0.853", KgM2 = "4.163" });
        data.Add(new GuageChart() { Guage = "26", Inches = "0.0179", Mm = "0.455", LbFt2 = "0.730", KgM2 = "3.565" });
        data.Add(new GuageChart() { Guage = "27", Inches = "0.0164", Mm = "0.417", LbFt2 = "0.669", KgM2 = "3.267" });
        data.Add(new GuageChart() { Guage = "28", Inches = "0.0149", Mm = "0.378", LbFt2 = "0.608", KgM2 = "2.968" });
        data.Add(new GuageChart() { Guage = "29", Inches = "0.0135", Mm = "0.343", LbFt2 = "0.551", KgM2 = "2.689" });
        data.Add(new GuageChart() { Guage = "30", Inches = "0.0120", Mm = "0.305", LbFt2 = "0.490", KgM2 = "2.390" });
        data.Add(new GuageChart() { Guage = "31", Inches = "0.0105", Mm = "0.267", LbFt2 = "0.428", KgM2 = "2.091" });
        data.Add(new GuageChart() { Guage = "32", Inches = "0.0097", Mm = "0.246", LbFt2 = "0.396", KgM2 = "1.932" });
        data.Add(new GuageChart() { Guage = "33", Inches = "0.0090", Mm = "0.229", LbFt2 = "0.367", KgM2 = "1.793" });
        data.Add(new GuageChart() { Guage = "34", Inches = "0.0082", Mm = "0.208", LbFt2 = "0.335", KgM2 = "1.633" });
        data.Add(new GuageChart() { Guage = "35", Inches = "0.0075", Mm = "0.191", LbFt2 = "0.306", KgM2 = "1.494" });
        data.Add(new GuageChart() { Guage = "36", Inches = "0.0067", Mm = "0.170", LbFt2 = "0.273", KgM2 = "1.335" });
        data.Add(new GuageChart() { Guage = "37", Inches = "0.0064", Mm = "0.163", LbFt2 = "0.261", KgM2 = "1.275" });
        data.Add(new GuageChart() { Guage = "38", Inches = "0.0060", Mm = "0.152", LbFt2 = "0.245", KgM2 = "1.195" });

        return Task.FromResult(data.ToArray());
    }
}



