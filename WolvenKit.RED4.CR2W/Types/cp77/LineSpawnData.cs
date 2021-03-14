using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LineSpawnData : IScriptable
	{
		private scnDialogLineData _lineData;

		[Ordinal(0)] 
		[RED("lineData")] 
		public scnDialogLineData LineData
		{
			get
			{
				if (_lineData == null)
				{
					_lineData = (scnDialogLineData) CR2WTypeManager.Create("scnDialogLineData", "lineData", cr2w, this);
				}
				return _lineData;
			}
			set
			{
				if (_lineData == value)
				{
					return;
				}
				_lineData = value;
				PropertySet(this);
			}
		}

		public LineSpawnData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
