using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionDelayedSpawnRequest : gameScriptableSystemRequest
	{
		private CEnum<EPreventionHeatStage> _heatStage;

		[Ordinal(0)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get
			{
				if (_heatStage == null)
				{
					_heatStage = (CEnum<EPreventionHeatStage>) CR2WTypeManager.Create("EPreventionHeatStage", "heatStage", cr2w, this);
				}
				return _heatStage;
			}
			set
			{
				if (_heatStage == value)
				{
					return;
				}
				_heatStage = value;
				PropertySet(this);
			}
		}

		public PreventionDelayedSpawnRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
