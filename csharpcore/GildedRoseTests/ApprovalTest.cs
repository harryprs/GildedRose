using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using GildedRoseTests;
using NUnit.Framework;
using Xunit;

namespace csharp
{
	public class ApprovalTest
	{
		[Fact]
		[UseReporter(typeof(DiffReporter))]
		public void ThirtyDays()
		{
			StringBuilder fakeoutput = new StringBuilder();
			Console.SetOut(new StringWriter(fakeoutput));
			Console.SetIn(new StringReader("a\n"));

			TexttestFixture.Main(new string[] { });
			var output = fakeoutput.ToString();

			Approvals.Verify(output);
		}
	}
}