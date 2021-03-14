using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameTime : CVariable
	{
		private CInt32 _seconds;

		[Ordinal(0)] 
		[RED("seconds")] 
		public CInt32 Seconds
		{
			get
			{
				if (_seconds == null)
				{
					_seconds = (CInt32) CR2WTypeManager.Create("Int32", "seconds", cr2w, this);
				}
				return _seconds;
			}
			set
			{
				if (_seconds == value)
				{
					return;
				}
				_seconds = value;
				PropertySet(this);
			}
		}

		public GameTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
