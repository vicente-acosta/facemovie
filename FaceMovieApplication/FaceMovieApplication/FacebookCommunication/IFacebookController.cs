﻿//-----------------------------------------------------------------------
// <copyright file="IFacebookController.cs" company="Interpool">
//     Copyright Interpool. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace FaceMovieApplication.FacebookCommunication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FaceMovieApplication.Datatypes;
    
    /// <summary>
    /// Interface Description IFacebookController
    /// </summary>
    public interface IFacebookController
    {
        /// <summary>
        /// Description for Method.</summary>
        /// <param name="auth"> Parameter description for auth goes here</param>
        Dictionary<long, User> GetUsersFacebookData(OAuthFacebook auth);
        
    }
}
