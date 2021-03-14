using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionCrimeWitnessRequest : gameScriptableSystemRequest
	{
		private Vector4 _criminalPosition;

		[Ordinal(0)] 
		[RED("criminalPosition")] 
		public Vector4 CriminalPosition
		{
			get
			{
				if (_criminalPosition == null)
				{
					_criminalPosition = (Vector4) CR2WTypeManager.Create("Vector4", "criminalPosition", cr2w, this);
				}
				return _criminalPosition;
			}
			set
			{
				if (_criminalPosition == value)
				{
					return;
				}
				_criminalPosition = value;
				PropertySet(this);
			}
		}

		public PreventionCrimeWitnessRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
