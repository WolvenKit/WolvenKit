using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LightGroupsAreaSettings : IAreaSettings
	{
		private CArrayFixedSize<curveData<CFloat>> _groupFade;

		[Ordinal(2)] 
		[RED("groupFade", 8)] 
		public CArrayFixedSize<curveData<CFloat>> GroupFade
		{
			get
			{
				if (_groupFade == null)
				{
					_groupFade = (CArrayFixedSize<curveData<CFloat>>) CR2WTypeManager.Create("[8]curveData:Float", "groupFade", cr2w, this);
				}
				return _groupFade;
			}
			set
			{
				if (_groupFade == value)
				{
					return;
				}
				_groupFade = value;
				PropertySet(this);
			}
		}

		public LightGroupsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
