using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerPeekScale : animAnimFeature
	{
		private CFloat _peekScale;

		[Ordinal(0)] 
		[RED("peekScale")] 
		public CFloat PeekScale
		{
			get
			{
				if (_peekScale == null)
				{
					_peekScale = (CFloat) CR2WTypeManager.Create("Float", "peekScale", cr2w, this);
				}
				return _peekScale;
			}
			set
			{
				if (_peekScale == value)
				{
					return;
				}
				_peekScale = value;
				PropertySet(this);
			}
		}

		public AnimFeature_PlayerPeekScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
