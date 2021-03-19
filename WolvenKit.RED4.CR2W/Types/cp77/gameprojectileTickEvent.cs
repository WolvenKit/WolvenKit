using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileTickEvent : redEvent
	{
		private CFloat _deltaTime;
		private Vector4 _position;

		[Ordinal(0)] 
		[RED("deltaTime")] 
		public CFloat DeltaTime
		{
			get => GetProperty(ref _deltaTime);
			set => SetProperty(ref _deltaTime, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		public gameprojectileTickEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
