using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHACK_UseSensePresetEvent : redEvent
	{
		private TweakDBID _sensePreset;

		[Ordinal(0)] 
		[RED("sensePreset")] 
		public TweakDBID SensePreset
		{
			get
			{
				if (_sensePreset == null)
				{
					_sensePreset = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "sensePreset", cr2w, this);
				}
				return _sensePreset;
			}
			set
			{
				if (_sensePreset == value)
				{
					return;
				}
				_sensePreset = value;
				PropertySet(this);
			}
		}

		public gameHACK_UseSensePresetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
