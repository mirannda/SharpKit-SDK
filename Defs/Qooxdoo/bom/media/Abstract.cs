// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.media
{
    /// <summary>
	/// <para>EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION</para>
	/// <para>Media element. Other media types can derive from this class.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.media.Abstract", OmitOptionalParameters = true, Export = false)]
    public abstract partial class Abstract : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Fired when the media has finished to play</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnEnded;

		/// <summary>
		/// <para>Fired when the media is laoded enough to start play</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnLoadeddata;

		/// <summary>
		/// <para>Fired when the media is laoded enough to start play</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnLoadedmetadata;

		/// <summary>
		/// <para>Fired when the media is paused</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnPause;

		/// <summary>
		/// <para>Fired when the media starts to play</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnPlay;

		/// <summary>
		/// <para>Fired when the current time of the media has changed</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnTimeupdate;

		/// <summary>
		/// <para>Fired when the volume property is changed</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnVolumechange;

		#endregion Events

		#region Methods

		public Abstract() { throw new NotImplementedException(); }

		/// <param name="media">the media element.</param>
		public Abstract(object media) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the browser can play the file format.</para>
		/// </summary>
		/// <param name="type">the file format</param>
		/// <returns></returns>
		[JsMethod(Name = "canPlayType")]
		public bool CanPlayType(string type) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the media is played directly when it is loaded / the page is loaded.</para>
		/// </summary>
		/// <returns>if autoplay is on or not</returns>
		[JsMethod(Name = "getAutoplay")]
		public bool GetAutoplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Gets current time of the playback.</para>
		/// </summary>
		/// <returns>the current time</returns>
		[JsMethod(Name = "getCurrentTime")]
		public double GetCurrentTime() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Gets the duration of the loaded media file.</para>
		/// </summary>
		/// <returns>the duration</returns>
		[JsMethod(Name = "getDuration")]
		public double GetDuration() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Gets the id of the media.</para>
		/// </summary>
		/// <returns>the id of the media element</returns>
		[JsMethod(Name = "getId")]
		public string GetId() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the media object, so that you can add it to the DOM.</para>
		/// </summary>
		/// <returns>the native media object</returns>
		[JsMethod(Name = "getMediaObject")]
		public object GetMediaObject() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns how much buffering the media resource will likely need.</para>
		/// </summary>
		/// <returns>hint how much buffering the media resource needs</returns>
		[JsMethod(Name = "getPreload")]
		public string GetPreload() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Gets the source url of the media file.</para>
		/// </summary>
		/// <returns>the source url to the media file.</returns>
		[JsMethod(Name = "getSource")]
		public string GetSource() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Gets the current playback volume, as a number in the range 0.0 to 1.0,
		/// where 0.0 is the quietest and 1.0 the loudest.</para>
		/// </summary>
		/// <returns>0.0 &#8211; 1.0</returns>
		[JsMethod(Name = "getVolume")]
		public double GetVolume() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks if the media element shows its controls.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "hasControls")]
		public bool HasControls() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Hides the controls of the media element.</para>
		/// </summary>
		[JsMethod(Name = "hideControls")]
		public void HideControls() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks if the media is ended or not.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "isEnded")]
		public bool IsEnded() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the media element is to seek back to the start of the media resource upon reaching the end.</para>
		/// </summary>
		/// <returns>if loop is on or not</returns>
		[JsMethod(Name = "isLoop")]
		public bool IsLoop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks if the media element is muted or not</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "isMuted")]
		public bool IsMuted() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks if the media is paused or not.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "isPaused")]
		public bool IsPaused() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Pauses playback of the media.</para>
		/// </summary>
		[JsMethod(Name = "pause")]
		public void Pause() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Starts playback of the media.</para>
		/// </summary>
		[JsMethod(Name = "play")]
		public void Play() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Plays the media directly when it is loaded / the page is loaded.</para>
		/// </summary>
		/// <param name="autoplay">To autoplay or not</param>
		[JsMethod(Name = "setAutoplay")]
		public void SetAutoplay(bool autoplay) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the value of current time.</para>
		/// </summary>
		/// <param name="value">the new value of current time</param>
		[JsMethod(Name = "setCurrentTime")]
		public void SetCurrentTime(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the id of the media.</para>
		/// </summary>
		/// <param name="id">The new value of id</param>
		[JsMethod(Name = "setId")]
		public void SetId(string id) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Indicates that the media element is to seek back to the start of the media resource upon reaching the end.</para>
		/// </summary>
		/// <param name="value">To loop or not.</param>
		[JsMethod(Name = "setLoop")]
		public void SetLoop(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the media element to mute.</para>
		/// </summary>
		/// <param name="muted">new value for mute</param>
		[JsMethod(Name = "setMuted")]
		public void SetMuted(bool muted) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Hints how much buffering the media resource will likely need.</para>
		/// </summary>
		/// <param name="preload">One of the following values: &#8220;none&#8221;: Hints to the user agent that either the author does not expect the user to need the media resource, or that the server wants to minimise unnecessary traffic. &#8220;metadata&#8221;: Hints to the user agent that the author does not expect the user to need the media resource, but that fetching the resource metadata (dimensions, first frame, track list, duration, etc) is reasonable. &#8220;auto&#8221;: Hints to the user agent that the user agent can put the user&#8217;s needs first without risk to the server, up to and including optimistically downloading the entire resource.</param>
		[JsMethod(Name = "setPreload")]
		public void SetPreload(string preload) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the source url of the media file.</para>
		/// </summary>
		/// <param name="source">the source url to the media file.</param>
		[JsMethod(Name = "setSource")]
		public void SetSource(string source) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the current playback volume, as a number in the range 0.0 to 1.0,
		/// where 0.0 is the quietest and 1.0 the loudest.</para>
		/// </summary>
		/// <param name="volume">0.0 &#8211; 1.0</param>
		[JsMethod(Name = "setVolume")]
		public void SetVolume(double volume) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Shows the controls of the media element.</para>
		/// </summary>
		[JsMethod(Name = "showControls")]
		public void ShowControls() { throw new NotImplementedException(); }

		#endregion Methods
    }
}