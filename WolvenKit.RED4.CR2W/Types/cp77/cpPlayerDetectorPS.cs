using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpPlayerDetectorPS : gameObjectPS
	{
		private CInt32 _secondsCounter;

		[Ordinal(0)] 
		[RED("secondsCounter")] 
		public CInt32 SecondsCounter
		{
			get
			{
				if (_secondsCounter == null)
				{
					_secondsCounter = (CInt32) CR2WTypeManager.Create("Int32", "secondsCounter", cr2w, this);
				}
				return _secondsCounter;
			}
			set
			{
				if (_secondsCounter == value)
				{
					return;
				}
				_secondsCounter = value;
				PropertySet(this);
			}
		}

		public cpPlayerDetectorPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
