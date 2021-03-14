using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhoneWaveformData : IScriptable
	{
		private CArray<Vector4> _points;

		[Ordinal(0)] 
		[RED("points")] 
		public CArray<Vector4> Points
		{
			get
			{
				if (_points == null)
				{
					_points = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "points", cr2w, this);
				}
				return _points;
			}
			set
			{
				if (_points == value)
				{
					return;
				}
				_points = value;
				PropertySet(this);
			}
		}

		public gameuiPhoneWaveformData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
