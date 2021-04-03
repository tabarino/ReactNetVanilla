import React from 'react';
import styles from './CommentList.module.css';
import Comment from '../Comment/Comment';

const CommentList = (props) => {
  const commentNodes = props.comments.map(comment => (
    <Comment author={comment.author} key={comment.id}>
      {comment.text}
    </Comment>
  ));

  return (
    <div className={styles.CommentList}>{commentNodes}</div>
  );
}

export default CommentList;
