using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Stance : animAnimFeature
	{
		private CInt32 _stanceState;

		[Ordinal(0)] 
		[RED("stanceState")] 
		public CInt32 StanceState
		{
			get
			{
				if (_stanceState == null)
				{
					_stanceState = (CInt32) CR2WTypeManager.Create("Int32", "stanceState", cr2w, this);
				}
				return _stanceState;
			}
			set
			{
				if (_stanceState == value)
				{
					return;
				}
				_stanceState = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_Stance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
