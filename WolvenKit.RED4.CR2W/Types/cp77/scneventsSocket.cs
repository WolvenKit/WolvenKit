using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsSocket : scnSceneEvent
	{
		private scnOutputSocketStamp _osockStamp;

		[Ordinal(6)] 
		[RED("osockStamp")] 
		public scnOutputSocketStamp OsockStamp
		{
			get
			{
				if (_osockStamp == null)
				{
					_osockStamp = (scnOutputSocketStamp) CR2WTypeManager.Create("scnOutputSocketStamp", "osockStamp", cr2w, this);
				}
				return _osockStamp;
			}
			set
			{
				if (_osockStamp == value)
				{
					return;
				}
				_osockStamp = value;
				PropertySet(this);
			}
		}

		public scneventsSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
