/*
 * Created by SharpDevelop.
 * User: Ashish Kamble
 * Date: 23-04-2024
 * Time: 18:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Newtonsoft.Json.Linq;

namespace wallCreate
{
	/// <summary>
	/// Description of GetData.
	/// </summary>
	public class GetData
	{
		public static double getVertex(string vetexID, out JObject builderRoot){
			return builderRoot["layers"][layerName]["vertices"][vetexID]["x"].ToObject<double>();
		}
	}
}
