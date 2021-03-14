using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadeAnimFeatureChangeEvent : redEvent
	{
		private CInt32 _newState;

		[Ordinal(0)] 
		[RED("newState")] 
		public CInt32 NewState
		{
			get
			{
				if (_newState == null)
				{
					_newState = (CInt32) CR2WTypeManager.Create("Int32", "newState", cr2w, this);
				}
				return _newState;
			}
			set
			{
				if (_newState == value)
				{
					return;
				}
				_newState = value;
				PropertySet(this);
			}
		}

		public GrenadeAnimFeatureChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
