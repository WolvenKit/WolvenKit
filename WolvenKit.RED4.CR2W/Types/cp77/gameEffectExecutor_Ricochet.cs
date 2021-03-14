using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_Ricochet : gameEffectExecutor
	{
		private gameEffectOutputParameter_Vector _outputRicochetVector;

		[Ordinal(1)] 
		[RED("outputRicochetVector")] 
		public gameEffectOutputParameter_Vector OutputRicochetVector
		{
			get
			{
				if (_outputRicochetVector == null)
				{
					_outputRicochetVector = (gameEffectOutputParameter_Vector) CR2WTypeManager.Create("gameEffectOutputParameter_Vector", "outputRicochetVector", cr2w, this);
				}
				return _outputRicochetVector;
			}
			set
			{
				if (_outputRicochetVector == value)
				{
					return;
				}
				_outputRicochetVector = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor_Ricochet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
