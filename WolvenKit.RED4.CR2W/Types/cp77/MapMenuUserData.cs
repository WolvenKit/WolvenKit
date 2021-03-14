using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MapMenuUserData : IScriptable
	{
		private Vector3 _moveTo;

		[Ordinal(0)] 
		[RED("moveTo")] 
		public Vector3 MoveTo
		{
			get
			{
				if (_moveTo == null)
				{
					_moveTo = (Vector3) CR2WTypeManager.Create("Vector3", "moveTo", cr2w, this);
				}
				return _moveTo;
			}
			set
			{
				if (_moveTo == value)
				{
					return;
				}
				_moveTo = value;
				PropertySet(this);
			}
		}

		public MapMenuUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
