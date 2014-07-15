using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class ProgramTest
	{
		private Program program;

		[Test]
		public void CanCreateAProgram ()
		{
			Item itemA = new Item ();
			Item itemB = new Item ();

			program = new Program (itemA, itemB);

			Assert.IsNotNull (program);
		}
	}
}
