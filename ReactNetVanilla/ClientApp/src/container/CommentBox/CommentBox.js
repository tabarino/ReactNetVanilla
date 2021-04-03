import React, { Component } from 'react';
import CommentForm from '../../components/CommentForm/CommentForm';
import CommentList from '../../components/CommentList/CommentList';

export class CommentBox extends Component {
  render() {
    const data = [
      { id: 1, author: 'Daniel Lo Nigro', text: 'Hello ReactJS.NET World!' },
      { id: 2, author: 'Pete Hunt', text: 'This is one comment' },
      { id: 3, author: 'Jordan Walke', text: 'This is another comment' },
    ];

    return (
      <div>
        <h1>Comments</h1>
        <CommentList data={data} />
        <CommentForm />
      </div>
    );
  }
}
