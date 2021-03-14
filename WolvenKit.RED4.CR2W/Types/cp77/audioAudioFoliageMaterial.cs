using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioFoliageMaterial : CVariable
	{
		private CName _loopStart;
		private CName _loopEnd;

		[Ordinal(0)] 
		[RED("loopStart")] 
		public CName LoopStart
		{
			get
			{
				if (_loopStart == null)
				{
					_loopStart = (CName) CR2WTypeManager.Create("CName", "loopStart", cr2w, this);
				}
				return _loopStart;
			}
			set
			{
				if (_loopStart == value)
				{
					return;
				}
				_loopStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("loopEnd")] 
		public CName LoopEnd
		{
			get
			{
				if (_loopEnd == null)
				{
					_loopEnd = (CName) CR2WTypeManager.Create("CName", "loopEnd", cr2w, this);
				}
				return _loopEnd;
			}
			set
			{
				if (_loopEnd == value)
				{
					return;
				}
				_loopEnd = value;
				PropertySet(this);
			}
		}

		public audioAudioFoliageMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
