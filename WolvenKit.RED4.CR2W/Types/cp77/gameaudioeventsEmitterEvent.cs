using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsEmitterEvent : redEvent
	{
		private CName _emitterName;

		[Ordinal(0)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get
			{
				if (_emitterName == null)
				{
					_emitterName = (CName) CR2WTypeManager.Create("CName", "emitterName", cr2w, this);
				}
				return _emitterName;
			}
			set
			{
				if (_emitterName == value)
				{
					return;
				}
				_emitterName = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsEmitterEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
