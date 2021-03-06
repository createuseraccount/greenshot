﻿// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2018 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: http://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.ComponentModel;
using Dapplo.Config.Language;

#pragma warning disable 1591

namespace Greenshot.Addon.OneDrive.Configuration
{
    /// <summary>
    /// This interface contains all the translations for the OneDrive addon
    /// </summary>
    [Language("OneDrive")]
    public interface IOneDriveLanguage : ILanguage, INotifyPropertyChanged
    {
        string CommunicationWait { get; }

        string LabelUploadFormat { get; }

        string LabelLinkType { get; }

        string SettingsTitle { get; }

        string UploadFailure { get; }

        string UploadMenuItem { get; }

        string UsePageLink { get; }

        string ResetCredentialsButton { get; }
    }
}

#pragma warning restore 1591