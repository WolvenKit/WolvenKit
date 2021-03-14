using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaContextActivatedASTCD : audioAudioStateTransitionConditionData
	{
		private CName _areaMixingContext;

		[Ordinal(1)] 
		[RED("areaMixingContext")] 
		public CName AreaMixingContext
		{
			get
			{
				if (_areaMixingContext == null)
				{
					_areaMixingContext = (CName) CR2WTypeManager.Create("CName", "areaMixingContext", cr2w, this);
				}
				return _areaMixingContext;
			}
			set
			{
				if (_areaMixingContext == value)
				{
					return;
				}
				_areaMixingContext = value;
				PropertySet(this);
			}
		}

		public audioAmbientAreaContextActivatedASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
